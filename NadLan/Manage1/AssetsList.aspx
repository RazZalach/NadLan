<%@ Page Title="" Language="C#" MasterPageFile="~/Manage1/TheMaster1.Master" AutoEventWireup="true" CodeBehind="AssetsList.aspx.cs" Inherits="NadLan.Manage1.AssetsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
        <!-- ======= Intro Single ======= -->
    <section class="intro-single">
      <div class="container">
              <a class="btn btn-a" href="AssetAddEdit.aspx">הוספת נכס</a>
        <div class="row">
          <div class="col-md-12 col-lg-8">
         
              <h1 class="title-single" style="color:blue;">הנכסים שלך</h1>
        
          </div>
          <div class="col-md-12 col-lg-4">
            <nav aria-label="breadcrumb" class="breadcrumb-box d-flex justify-content-lg-end">
              <ol class="breadcrumb">
              </ol>
            </nav>
          </div>
        </div>
      </div>
    </section><!-- End Intro Single-->
       <!-- ======= Property Grid ======= -->
    <section class="property-grid grid">
      <div class="container">
        <div class="row">
          <div class="col-sm-12">
            <div class="grid-option">
            </div>
          </div>
          <asp:Repeater ID="rptprod" runat="server">
        <ItemTemplate>
              <div class="col-md-4">
            <div class="card-box-a card-shadow">
              <div class="img-box-a">
                <img src="/Uploade/Pics/<%#Eval("Pic") %>" class="img-a img-fluid">
              </div>
              <div class="card-overlay">
                <div class="card-overlay-a-content">
                  <div class="card-header-a">
                    <h2 class="card-title-a"><a ><%#Eval("Pname") %><br /> <%#Eval("PAddress") %><br /> <%#Eval("City") %></a></h2>
                  </div>
                  <div class="card-body-a">
                    <div class="price-box d-flex">
                      <span class="price-a">  <%#Eval("TypeDeal") %> | ₪ <%#Eval("PriceReq") %></span>
                    </div>
             <a href="AssetAddEdit.aspx?Pid=<%#Eval("Pid")%>" class="link-a">עריכת נכס 
                      <span class="bi bi-chevron-right"></span>
                    </a>
                  </div>
                  <div class="card-footer-a">
                    <ul class="card-info d-flex justify-content-around">
                      <li>
                        <h4 class="card-info-title">שטח</h4>
                        <span><%#Eval("Area") %> 
                          <sup> מ"ר</sup>
                        </span>
                      </li>
                      <li>
                        <h4 class="card-info-title">חדרים</h4>
                        <span><%#Eval("RoomNumber") %> </span>
                      </li>
                      <li>
                        <h4 class="card-info-title">קומה</h4>
                        <span><%#Eval("PFloor") %></span>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
      </div>
    </section><!-- End Property Grid Single--> 
</asp:Content>
