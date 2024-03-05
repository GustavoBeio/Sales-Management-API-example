using FluentValidation.Results;

namespace Sales.Domain.Validations.Base
{
    public static class GetValidation
    {
        public static Response GetErrors(this ValidationResult result)
        {
            Response response = new();

            if (!result.IsValid)
            {
                foreach (var error in result.Errors)
                {
                    response.Report.Add(new Report()
                    {
                        Code = error.PropertyName,
                        Message = error.ErrorMessage
                    });
                }
                return response;
            }
            return response;
        }
    }
}
