using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResources.Domain.Enums;

namespace HumanResources.Domain.Exceptions
{
    public class BusinessException : Exception
    {
        public string Param { get; set; }

        public ErrorEnum ErrorEnum { get; set; }


        public BusinessException() { }

        public BusinessException(string message) : base(message) { }

        public BusinessException(string message, string param) : base(message)
        {
            Param = param;
        }

        public BusinessException(string message, string param, ErrorEnum errorEnum) : base(message)
        {
            Param = param;
            ErrorEnum = errorEnum;
        }
    }
}