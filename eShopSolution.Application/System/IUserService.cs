﻿using eShopSolution.ViewModels.System;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.System
{
        public interface IUserService
        {
            Task<string> Authencate(LoginRequest request);

            Task<bool> Register(RegisterRequest request);
        }
    }

