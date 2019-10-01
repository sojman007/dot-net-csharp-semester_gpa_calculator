using System;
using System.Collections.Generic;
using System.Text;

namespace MyCustomApplication.Runtime
{
   
    class ApplicationStateManager
    {
        private bool isUserinSession = false;
        private bool isUserInGradeCalculator = false;
        private bool isUserInSettingsPage = false;
        private bool isUserInAboutPage = false;
        private bool recordingUserData = false;

        public bool getRecordingUserData() => recordingUserData;
        internal void setRecordingUserData(bool value) => recordingUserData = value;

        public bool getUserInSession() => isUserinSession;
        internal void setUserInSession(bool value)=> isUserinSession = value;
        
        public bool getIsUserInGradeCalculator() => isUserInGradeCalculator;
        internal  void setUserInGradeCalculator(bool value) => isUserInGradeCalculator = value;
        public bool getUserInSettingsPage() => isUserInSettingsPage;
        internal void setUserInSettingsPage(bool value) => isUserInSettingsPage = value;
        public bool getUserInAboutPage() => isUserInAboutPage;
        internal void setUserInAboutPage(bool value) => isUserInAboutPage = value;
    }

}
