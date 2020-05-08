﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
	public interface IUserService
	{
		Task<bool> RegisterUser(UserModel userMode);
		Task<bool> IsOnline(string name);
	}
}
