using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeWebService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        EmployeeResponse CreateEmployee(EmployeeRequest request);

        [OperationContract]
        List<EmployeeResponse> ReadAllEmployee();

        [OperationContract]
        EmployeeResponse ReadSpecificEmployee(EmployeeRequest request);

        [OperationContract]
        EmployeeResponse UpdateEmployee(EmployeeRequest request);

        [OperationContract]
        EmployeeResponse DeleteEmployee(EmployeeRequest request);
    }
}
