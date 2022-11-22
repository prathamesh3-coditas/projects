//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;
//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.AspNetCore.Mvc.ViewFeatures;
//using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
//using MVCApps1.Controllers;

//namespace MVCApps1.Custom_Filters
//{
//    public class DbExceptionAttribute : IExceptionFilter
//    {
//        private IModelMetadataProvider modelMetadataProvider;
//        Dictionary<string, string> ErrorDetails = new Dictionary<string, string>();
//        public DbExceptionAttribute(IModelMetadataProvider modelMetadataProvider)
//        {
//            this.modelMetadataProvider = modelMetadataProvider;
//            ErrorDetails.Add("Microsoft.Data.SqlClient.SqlException","DbErrors");
//        }

//        void IExceptionFilter.OnException(ExceptionContext context)
//        {

//            context.ExceptionHandled = true;
//            ViewDataDictionary viewData = new ViewDataDictionary(modelMetadataProvider, context.ModelState);

//            string msg = context.Exception.Message;

//            var typeOfException = context.Exception.GetType().ToString();

//            ViewResult result = new ViewResult();
//            if (ErrorDetails.ContainsKey(typeOfException))
//            {
//                result.ViewName = ErrorDetails[typeOfException];
//            }
//            else
//            {
//                result.ViewName = "Error";
//            }

            
//            viewData["Error"] = msg;

//            result.ViewData = viewData;
//            context.Result = result;
//        }
//    }
//}
