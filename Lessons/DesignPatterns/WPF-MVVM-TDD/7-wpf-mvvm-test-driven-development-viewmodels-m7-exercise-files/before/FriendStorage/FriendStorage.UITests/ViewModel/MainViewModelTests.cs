﻿using System;
using FriendStorage.UI.ViewModel;
using Xunit;
using Moq;
using Prism.Events;
using FriendStorage.UI.Events;
using System.Collections.Generic;
using System.Linq;
using FriendStorage.Model;
using FriendStorage.UITests.Extensions;
using FriendStorage.UI.Wrapper;

namespace FriendStorage.UITests.ViewModel
{
  public class MainViewModelTests
  {
    private Mock<INavigationViewModel> _navigationViewModelMock;
    private MainViewModel _viewModel;
    private Mock<IEventAggregator> _eventAggregatorMock;
    private OpenFriendEditViewEvent _openFriendEditViewEvent;
    private List<Mock<IFriendEditViewModel>> _friendEditViewModelMocks;

    public MainViewModelTests()
    {
      _friendEditViewModelMocks = new List<Mock<IFriendEditViewModel>>();
      _navigationViewModelMock = new Mock<INavigationViewModel>();

      _openFriendEditViewEvent = new OpenFriendEditViewEvent();
      _eventAggregatorMock = new Mock<IEventAggregator>();
      _eventAggregatorMock.Setup(ea => ea.GetEvent<OpenFriendEditViewEvent>())
        .Returns(_openFriendEditViewEvent);

      _viewModel = new MainViewModel(_navigationViewModelMock.Object,
        CreateFriendEditViewModel, _eventAggregatorMock.Object);
    }

    private IFriendEditViewModel CreateFriendEditViewModel()
    {
      var friendEditViewModelMock = new Mock<IFriendEditViewModel>();
      friendEditViewModelMock.Setup(vm => vm.Load(It.IsAny<int>()))
        .Callback<int>(friendId =>
        {
          friendEditViewModelMock.Setup(vm => vm.Friend)
          .Returns(new FriendWrapper(new Friend { Id = friendId }));
        });
      _friendEditViewModelMocks.Add(friendEditViewModelMock);
      return friendEditViewModelMock.Object;
    }

    [Fact]
    public void ShouldCallTheLoadMethodOfTheNavigationViewModel()
    {
      _viewModel.Load();

      _navigationViewModelMock.Verify(vm => vm.Load(), Times.Once);
    }

    [Fact]
    public void ShouldAddFriendEditViewModelAndLoadAndSelectIt()
    {
      const int friendId = 7;
      _openFriendEditViewEvent.Publish(friendId);

      Assert.Equal(1, _viewModel.FriendEditViewModels.Count);
      var friendEditVm = _viewModel.FriendEditViewModels.First();
      Assert.Equal(friendEditVm, _viewModel.SelectedFriendEditViewModel);
      _friendEditViewModelMocks.First().Verify(vm => vm.Load(friendId), Times.Once);
    }

    [Fact]
    public void ShouldAddFriendEditViewModelsOnlyOnce()
    {
      _openFriendEditViewEvent.Publish(5);
      _openFriendEditViewEvent.Publish(5);
      _openFriendEditViewEvent.Publish(6);
      _openFriendEditViewEvent.Publish(7);
      _openFriendEditViewEvent.Publish(7);

      Assert.Equal(3, _viewModel.FriendEditViewModels.Count);
    }

    [Fact]
    public void ShouldRaisePropertyChangedEventForSelectedFriendEditViewModel()
    {
      var friendEditVmMock = new Mock<IFriendEditViewModel>();
      var fired = _viewModel.IsPropertyChangedFired(() =>
      {
        _viewModel.SelectedFriendEditViewModel = friendEditVmMock.Object;
      }, nameof(_viewModel.SelectedFriendEditViewModel));

      Assert.True(fired);
    }

    [Fact]
    public void ShouldRemoveFriendEditViewModelOnCloseFriendTabCommand()
    {
      _openFriendEditViewEvent.Publish(7);

      var friendEditVm = _viewModel.SelectedFriendEditViewModel;

      _viewModel.CloseFriendTabCommand.Execute(friendEditVm);

      Assert.Equal(0, _viewModel.FriendEditViewModels.Count);
    }
  }
}
