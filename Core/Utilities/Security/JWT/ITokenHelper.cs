using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //ilgili kullanıcı için. kullanıcının claimlerini içerecek bir token üretiyor..
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
