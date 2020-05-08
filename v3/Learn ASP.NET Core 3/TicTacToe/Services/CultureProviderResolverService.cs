using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    public class CultureProviderResolverService 
        : RequestCultureProvider {
        private static readonly char[] _cookieSeparator = new[] { '|' };
        private static readonly string _culturePrefix = "c=";
        private static readonly string _uiCulturePrefix = "uic=";

        public override async Task<ProviderCultureResult> DetermineProviderCultureResult (HttpContext httpContext) {
            
        }
    }
}