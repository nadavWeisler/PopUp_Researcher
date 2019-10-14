﻿using System.Collections.Generic;
using PopUp_Researcher.Helpers;

namespace bRMS_Generator
{
    public class UserHelper
    {
        protected string name;
        protected string pass;
        protected List<Trial> experiments;

        public UserHelper(string _name, List<Trial> _experiments)
        {
            this.name = _name;
            this.experiments = _experiments;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetPass()
        {
            return this.pass;
        }
    }
}
