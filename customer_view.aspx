<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="customer_view.aspx.cs" Inherits="production_management.customer_view" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cplace" runat="server">
    <div class="content">
        <div class="row">
            <div class="col-md-8">
                <div class="card">
                    <div class="card-header">
                        <h5 class="title"> List of customers 

                            <a href="Customer_add.aspx" style="margin-left:450PX">  ADD NEW </a>
                        </h5>
                        
                    </div>
                    <div class="card-body">
                        <form runat="server">
                            <div class="row">
                                <div class="col-md-12">
                                    <table class="table">
                                        <thead class="text-primary">
                                            <tr>
                                            <td>Name</td>
                                            <td>Email</td>
                                            <td>Contact</td>
                                            <td>Fax</td>
                                            <td>Address</td>
                                            <td>City</td>
                                            <td>State</td>
                                            <td>Pin</td>
                                            <td>Action</td>
                                            </tr>
                                        </thead>
                                        <tbody>

                                            <asp:Repeater ID="rpt" runat="server">
                                                <ItemTemplate>

                                            <tr>
                                            <td><%#Eval("name") %></td>
                                            <td><%#Eval("email") %></td> 
                                            <td><%#Eval("contact") %></td>
                                            <td><%#Eval("fax") %></td>
                                            <td><%#Eval("address") %></td>
                                            <td><%#Eval("city") %></td> 
                                            <td><%#Eval("state") %></td>
                                            <td><%#Eval("pin") %></td>
                                            <td> 

<a href="customer_edit.aspx?cust_id=<%#Eval("cust_id") %>"> Edit </a>
|                                            
<a onclick="return confirm('do you want to delete it?)" href="customer_view.aspx?cust_id=<%#Eval("cust_id") %>"> Delete </a>
                                                        
                                            </td>
                                           
                                             </tr>
                                            
                                                </ItemTemplate>
                                                    
                                            </asp:Repeater>


                                        </tbody>
                                    </table>
                                </div>
                            </div>
                           
                        </form>
                    </div>
                    </div>
            </div>
            <div class="col-md-4">
                <div class="card  card-user">
                    <div class="card-body ">
                        <p class="card-text">
                        <div class="author">
                            <div class="block block-one">
                            </div>
                            <div class="block block-two">
                            </div>
                            <div class="block block-three">
                            </div>
                            <div class="block block-four">
                            </div>
                            <a href="#">
                            <img class="avatar" src="../assets/img/anime6.png" alt="...">
                            <h5 class="title">Mike Andrew</h5>
                            </a>&nbsp;<p class="description">
                                Ceo/Co-Founder
                            </p>
                        </div>
                        </p>
                        <p class="card-description">
                            Do not be scared of the truth because we need to restart the human foundation in truth And I love you like Kanye loves Kanye I love Rick Owens’ bed design but the back is...
                        </p>
                    </div>
                    <div class="card-footer ">
                        <div class="button-container">
                            <button href="#" class="btn btn-icon btn-round btn-facebook">
                                <i class="fab fa-facebook"></i>
                            </button>
                            <button href="#" class="btn btn-icon btn-round btn-twitter">
                                <i class="fab fa-twitter"></i>
                            </button>
                            <button href="#" class="btn btn-icon btn-round btn-google">
                                <i class="fab fa-google-plus"></i>
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
