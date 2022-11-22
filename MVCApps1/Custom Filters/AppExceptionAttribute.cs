using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Data.SqlClient;

namespace MVCApps1.Custom_Filters
{
    public class AppExceptionAttribute : IExceptionFilter
    {

        private IModelMetadataProvider modelMetadataProvider;
        Dictionary<string, string> ErrorDetails = new Dictionary<string, string>();

        public AppExceptionAttribute(IModelMetadataProvider modelMetadataProvider)
        {
            this.modelMetadataProvider = modelMetadataProvider;
            ErrorDetails.Add("Microsoft.Data.SqlClient.SqlException", "DbErrors");

        }

        void IExceptionFilter.OnException(ExceptionContext context)
        {

            context.ExceptionHandled = true;

            string errorMsg = context.Exception.Message;

            var typeOfException = context.Exception.GetType().ToString();


            ViewResult result = new ViewResult();

            if (context.Exception.GetType() == typeof(SqlException))
            {
                result.ViewName = ErrorDetails[typeOfException];
            }
            else
            {
                result.ViewName = "Error";
            }

            ViewDataDictionary viewData = new ViewDataDictionary(modelMetadataProvider, context.ModelState);

            viewData["Controller"] = context.RouteData.Values["controller"].ToString();
            viewData["Action"] = context.RouteData.Values["action"].ToString();
            viewData["Error"] = errorMsg;

            result.ViewData = viewData;

            context.Result = result;
        }
    }
}
