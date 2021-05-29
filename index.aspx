<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My browser</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>
    <link rel="preconnect" href="https://fonts.gstatic.com"/>
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@300&display=swap" rel="stylesheet"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body style="background:#101010">
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
        <a class="navbar-brand" href="#">Navbar</a>
        <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
            <ul class="navbar-nav">
            <li class="nav-item">
                <a class="nav-link active" aria-current="page" href="#">Home</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Features</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Pricing</a>
            </li>
            <li class="nav-item">
                <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
            </li>
            </ul>
        </div>
        </div>
    </nav>
    <div class="container p-5">
        <div class="jumbotron text-center">
            <h1>My First web browser Page</h1>
            <p>Put your search Query in the textbox with https://</p> 
        </div>
        <form id="form1" runat="server">
            <div class="row">
                <div class="col-sm-2">
                    <p style="color:#EEFFFF;">Search Here :</p>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBox1" runat="server" Style="border-radius:15px; width:100%; color:#101010;"></asp:TextBox>
                </div>
                <div class="col-sm-6">
                    <asp:Button ID="Button1" runat="server" Text="Search" CssClass="btn btn-outline-primary" OnClick="Button1_Click" OnClientClick="SetTarget();" />
                    <script type="text/javascript">
                        function SetTarget() {
                            document.forms[1].target = "_self";
                        }
                    </script>    
                </div>
            </div>
        </form>
    </div>
</body>
</html>
