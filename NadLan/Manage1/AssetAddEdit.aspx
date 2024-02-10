<%@ Page Title="" Language="C#" MasterPageFile="~/Manage1/TheMaster1.Master" AutoEventWireup="true" CodeBehind="AssetAddEdit.aspx.cs" Inherits="NadLan.Manage1.AssetAddEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
        <!-- ======= Property Single ======= -->
      <div class="container">
                  <section class="intro-single">
                          <div class="col-md-5" style="margin-left:30%;">
               <div class="card-box-a card-shadow">
              <div class="img-box-a">
                <asp:Literal ID="ltl" runat="server"></asp:Literal>
              </div>
              <div class="card-overlay">
                <div class="card-overlay-a-content">
               </div>
                </div>
              </div>
            </div>               
          <h3 class="w-title-a text-brand">עריכת נכס</h3>
      <div class="container">
                                     <div class="col-md-3 mb-3">
                                    <div class="form-group" >
                                        <asp:HiddenField ID="HiddenPid" runat="server" />
                                        <asp:HiddenField ID="HiddenAid" runat="server" />
                                             <br /><asp:TextBox ID="Name" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder="  שם נכס"></asp:TextBox>
                                             </div>
                                                </div>
                                     <div class="col-md-3 mb-3">
                                     <div class="form-group" >
                                             <br /><asp:TextBox ID="roomnumber" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder=" מספר חדרים"></asp:TextBox>
                                             </div>
                                         </div>
                                        <div class="col-md-3 mb-3">
                                     <div class="form-group" >           
                                             <br /><asp:TextBox ID="Floor" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder=" קומה"></asp:TextBox>
                                             </div>
                                            </div>
                                      <div class="col-md-3 mb-3">
                                     <div class="form-group" >
                                             <br /><asp:TextBox ID="Address" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder="  כתובת"></asp:TextBox>
                                             </div>
                                          </div>
                                     <div class="col-md-3 mb-3">
                                     <div class="form-group" >
                                             <br /><asp:TextBox ID="City" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder="  עיר"></asp:TextBox>
                                             </div>
                                         </div>
                                     <div class="col-md-3 mb-3">
                                     <div class="form-group" >
                                             <br /><asp:TextBox ID="Area" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder="שטח במר"></asp:TextBox>
                                             </div>
                                   </div>
                                    <div class="col-md-3 mb-3">
                                     <div class="form-group" >
                                             <br /><asp:TextBox ID="Price" runat="server" CssClass="form-control form-control-lg form-control-a" placeholder=" מחיר "></asp:TextBox>
                                             </div>
                                        </div>
                                      <div class="col-md-3 mb-3">
                                      <div class="form-group" >
                                             <br /><asp:DropDownList ID="droplist" runat="server"></asp:DropDownList>
                                             </div>
                                          </div>
                                         <div class="col-md-3 mb-3">
                                        <div class="form-group">
                                             <br />
                                                  <asp:FileUpload ID="uploade" runat="server" />
                                                  <asp:RequiredFieldValidator ID="up" ControlToValidate="uploade" runat="server" Text="*" ForeColor="Red"></asp:RequiredFieldValidator>
                                            </div>
                                             </div>                                 
                                          <h4><asp:CheckBox ID="checkbox" runat="server" Text="מחק נכס" AutoPostBack=true OnCheckedChanged="checkbox_CheckedChanged" /></h4>
                                      <br />   
                             <asp:Button ID="Btn_Add" runat="server" Text="שמור" CssClass="btn btn-a" OnClick="Btn_Add_Click"  />
                                       <asp:Literal ID="ltlfield" runat="server"></asp:Literal> 
                                        </div>                  
    </section><!-- End Intro Single-->
               <div class="col-md-10 offset-md-1">
            <ul class="nav nav-pills-a nav-pills mb-3 section-t3" id="pills-tab" role="tablist">
              <li class="nav-item">
                <a class="nav-link active" id="pills-video-tab" data-bs-toggle="pill" href="#pills-video" role="tab" aria-controls="pills-video" aria-selected="true">וידאו דמו</a>
              </li>         
              <li class="nav-item">
                <a class="nav-link" id="pills-map-tab" data-bs-toggle="pill" href="#pills-map" role="tab" aria-controls="pills-map" aria-selected="false">מיקום</a>
              </li>
            </ul>
            <div class="tab-content" id="pills-tabContent">
              <div class="tab-pane fade show active" id="pills-video" role="tabpanel" aria-labelledby="pills-video-tab">
                <iframe src="https://player.vimeo.com/video/73221098" width="100%" height="460" frameborder="0" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>
              </div>
              <div class="tab-pane fade" id="pills-plans" role="tabpanel" aria-labelledby="pills-plans-tab">
                <img src="assets/img/plan2.jpg" alt="" class="img-fluid">
              </div>
              <div class="tab-pane fade" id="pills-map" role="tabpanel" aria-labelledby="pills-map-tab">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3022.1422937950147!2d-73.98731968482413!3d40.75889497932681!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c25855c6480299%3A0x55194ec5a1ae072e!2sTimes+Square!5e0!3m2!1ses-419!2sve!4v1510329142834" width="100%" height="460" frameborder="0" style="border:0" allowfullscreen></iframe>
              </div>
            </div>
          </div>
            </div>
   <!-- End Property Single-->
</asp:Content>
