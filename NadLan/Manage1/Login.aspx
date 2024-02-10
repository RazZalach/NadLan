<%@ Page Title="" Language="C#" MasterPageFile="~/Manage1/TheMaster1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NadLan.Manage1.Login" %>
<%@ Register Src="~/Manage1/AC.ascx" TagName="AC" TagPrefix="ACLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <main id="main" class="intro-single" style="margin-right:35%;">      
            <section class="section-services section-t8">
      <div class="container">
              <div class="row">
          <div class="col-md-12">
            <div class="title-wrap d-flex justify-content-between">
              <div class="title-box">  
    <ACLogin:AC ID="ac" runat="server"  />
                         </div>
            </div>
          </div>
        </div>
          </div>
                </section>
        </main>    
</asp:Content>
