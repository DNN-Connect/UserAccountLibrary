﻿Imports DotNetNuke.Entities.Users

Namespace Connect.Libraries.UserManagement.Interfaces

    Public Interface iAccountUpdate

        Sub FinalizeAccountUpdate(ByRef Server As System.Web.HttpServerUtility, ByRef Response As HttpResponse, ByRef Request As HttpRequest, ByVal objUser As UserInfo)

    End Interface

End Namespace

