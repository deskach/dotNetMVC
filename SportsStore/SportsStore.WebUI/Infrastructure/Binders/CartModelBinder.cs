using System.Web.Mvc;
using SportsStore.Domain.Entities;

/*  Model Binding: Edit Application_Start method of Global.asax 
    to tell the MVC Framework that it should use CartModelBinder class to create instances of Cart. 
*/

namespace SportsStore.WebUI.Infrastructure.Binders {
    public class CartModelBinder : IModelBinder {
        private const string sessionKey = "Cart";

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext) {
            Cart cart = (Cart) controllerContext.HttpContext.Session[sessionKey]; ;

            if (cart == null) {
                cart = new Cart();
                controllerContext.HttpContext.Session[sessionKey] = cart;
            }

            return cart;
        }
    }
}