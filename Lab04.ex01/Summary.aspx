﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" Inherits="Lab01.ex01.Summary"%>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Участники семинара</title>
        <link rel="stylesheet" href="Styles.css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <h2>Приглашения</h2>
                <h3>Не выступающие с докладом: </h3>
                <table>
                <thead>
                <tr>
                <th>Имя</th>
                <th>Email</th>
                <th>Телефон</th>
                </tr>
                </thead>
                <tbody> 
                   <%= GetNoShowHtml()%>
                </tbody>
                </table>
            </div>
        </form>
    </body>
</html>
