using System;
using System.ComponentModel;

namespace dxSampleGrid {
    public partial class MyViewModel : INotifyPropertyChanged{
   
        public MyViewModel() {
            WaitIndicatorText = "Loading...";
        }
 
        bool _isWaitIndicatorVisible;
        string _waitIndicatorText;

        public bool IsWaitIndicatorVisible {
            get {
                return _isWaitIndicatorVisible;
            }

            set {
                _isWaitIndicatorVisible = value;
                RaisePropertyChanged("IsWaitIndicatorVisible");
            }
        }

        public string WaitIndicatorText {
            get {
                return _waitIndicatorText;
            }

            set {
                _waitIndicatorText = value;
                RaisePropertyChanged("WaitIndicatorText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String propertyName) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    } 
}
