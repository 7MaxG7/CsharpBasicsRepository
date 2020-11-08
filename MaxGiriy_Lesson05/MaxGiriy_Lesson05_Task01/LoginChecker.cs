using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace MaxGiriy_Lesson05_Task01 {
    public static class LoginChecker {
        public static bool CkeckLogin(string userLogin, CheckMethod method) {
            switch (method) {
                case CheckMethod.RegularExpressions:
                    return RegularExpressionsCheck(userLogin);
                case CheckMethod.NoExpressions:
                default:
                    return NoExpressionsCheck(userLogin);
            }
        }
        static bool NoExpressionsCheck(string userLogin) {
            string lowerCaseLogin = userLogin.ToLower();
            if (lowerCaseLogin.Length < 2 || lowerCaseLogin.Length > 10) return false;
            if (lowerCaseLogin[0] < 'a' || lowerCaseLogin[0] > 'z') return false;
            foreach (var item in lowerCaseLogin) {
                if ((item < 'a' || item > 'z') && (item < '0' || item > '9')) return false;
            }
            return true;
        }
        static bool RegularExpressionsCheck(string userLogin) {
            string condition = @"^[a-zA-z]\w{1,9}$";
            Regex loginRegex = new Regex(condition);
            return loginRegex.IsMatch(userLogin);
        }
    }
}
