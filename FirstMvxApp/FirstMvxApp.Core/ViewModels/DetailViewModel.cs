using System;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Platform;

namespace FirstMvxApp.ViewModels {

	public class DetailViewModel : MvxViewModel {

		public DetailViewModel() {
			Mvx.Resolve<IMvxTrace>().Trace(MvxTraceLevel.Diagnostic, "DetailViewModel", "Constructor");
		}

		public void Init(string firstName, string lastName) {
			Mvx.Resolve<IMvxTrace>().Trace(MvxTraceLevel.Diagnostic, "DetailViewModel", "Init(firstname = {0}, lastName = {1})", firstName, lastName);
		}

	}
}

