﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class NewStateUserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
