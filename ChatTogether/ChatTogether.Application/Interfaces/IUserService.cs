
using ChatTogether.Application.ViewModels.User;

namespace ChatTogether.Application.Interfaces
{
    public interface IUserService
    {
        //Tutaj definiujemy definicję logiki apliakcji

        //Przykład
        //int AddUser(NewOrEditUserVm userVM);
        int AddUser(UserRegister newUser);
        bool IsSucceslogin(string nickName, string password);
        int GetUserId(string nickName);

    }
}
