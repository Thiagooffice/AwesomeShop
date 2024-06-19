using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Application.Dtos
{
    public class GenericHandlerResult<T> where T: class
    {
        public GenericHandlerResult(string message, T data, bool sucess, List<ValidationObject> validations)
        {
            Message = message;
            Data = data;
            Sucess = sucess;
            Validations = validations;
        }

        public string Message { get; private set; }
        public T Data { get; private set; }
        public bool Sucess { get; private set; }
        public List<ValidationObject> Validations { get; private set; }
    }

    public class ValidationObject{
        public ValidationObject(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; private set; }
        public string Message { get; private set; }
    }
}