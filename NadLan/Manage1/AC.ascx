<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AC.ascx.cs" Inherits="NadLan.Manage1.AC" %>
        <h4><asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack=true oncheckedchanged="CheckBox1_CheckedChanged" Text="סוכן חדש" ForeColor="Blue" /></h4>
                   <div class="form-group">
                            <asp:TextBox CssClass="form-control form-control-lg form-control-a" ID="AgentId" placeholder="תעודת זהות" runat="server" ></asp:TextBox>
                       <asp:RequiredFieldValidator ID="reqid" ControlToValidate="AgentId" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="regid" ControlToValidate="AgentId" runat="server" ErrorMessage="9 מספרים" ValidationExpression="^[0-9]{9}$"></asp:RegularExpressionValidator>
                           </div>
               <div class="form-group">
                                <asp:TextBox CssClass="form-control form-control-lg form-control-a" ID="passwor" placeholder="הזן סיסמא" TextMode="Password" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="reqpass" ControlToValidate="passwor" runat="server" ErrorMessage="*" ></asp:RequiredFieldValidator>
                   <asp:RegularExpressionValidator ID="regpass" runat="server" ControlToValidate="passwor" ErrorMessage="סיסמא באורך 8-10, תו בנאגלית ומספר אחד לפחות" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,10})$"></asp:RegularExpressionValidator>                                 
                      </div>
                       <div class="form-group">
                            <asp:TextBox CssClass="form-control form-control-lg form-control-a" Visible="false" ID="AgentName" placeholder="הזן שם סוכן" runat="server" ></asp:TextBox><br />
                              </div>
                            <div class="form-group">
                            <asp:TextBox CssClass="form-control form-control-lg form-control-a" Visible="false" ID="AgentLname" placeholder="הזן שם משפחה סוכן" runat="server" ></asp:TextBox><br />
                                </div>
                            <div class="form-group">
                            <asp:TextBox CssClass="form-control form-control-lg form-control-a" Visible="false" ID="Address" placeholder="כתובת סוכן" runat="server" ></asp:TextBox><br />
                                </div>
                            <div class="form-group">
                            <asp:TextBox CssClass="form-control form-control-lg form-control-a" Visible="false" ID="Phone" placeholder="טלפון סוכן" runat="server" ></asp:TextBox><br />
                                </div>  
                             <asp:Literal ID="ltllog" runat="server"></asp:Literal>
                                <asp:Button  ID="btnlogin" runat="server" OnClick="btnlogin_Click" CssClass="btn btn-a" Text="אימות" /> 
                               
               