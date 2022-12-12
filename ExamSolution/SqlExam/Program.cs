using SqlExam;

Controler controler=new Controler();
while(true)
{
    char result=controler.MainMenu();
    if (result == '1')
    {
        controler.SignUpForUser();
    }
    else if (result == '2')
    {

        int roleUser = controler.SignIn();
        if (roleUser == 0)
        {
            char actionAdmin = controler.AdminMenu();
        AdminsMenu:
            switch (actionAdmin)
            {
                case '1':
                    controler.AddRoom();
                    break;
                case '2':
                    controler.PrintAllRoom();
                    break;
                case '3':
                    controler.PrintAllRoom();
                    controler.DeleteRoom();
                    break;
                case '4':
                    return;
                default:
                    goto AdminsMenu;
            }


        }
        else if (roleUser == 1)
        {
            controler.PintAllOrder();
        }
        else if (roleUser == 2)
        {
        }
        else

        {
            Console.WriteLine("parol or login is false, please try again ");

        }

    }

}