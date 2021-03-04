using GraphQL.Types;
using GraphQL.Sample.Model;

namespace GraphQL.Sample.GraphQL.Types
{
   class CustomerGraphType : ObjectGraphType<Customer>
   {
      public CustomerGraphType()
      {
         Name = "Customer";
         Field(x => x.Id, type: typeof(IdGraphType)).Description("Customer Id");
         Field(x => x.FirstName).Description("Customer's First Name");
         Field(x => x.LastName).Description("Customer's Last Name");
         Field(x => x.Contact).Description("Customer's Contact");
         Field(x => x.Email).Description("Customer's Email");
      }
   }
}