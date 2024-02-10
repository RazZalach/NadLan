<%@ Page Title="" Language="C#" MasterPageFile="~/Manage1/TheMaster1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NadLan.Manage1.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
       <!-- ======= Intro Section ======= -->
  <div class="intro intro-carousel swiper position-relative">
    <div class="swiper-wrapper">
      <div class="swiper-slide carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-1.jpg)">
        <div class="overlay overlay-a"></div>
        <div class="intro-content display-table">
          <div class="table-cell">
            <div class="container">
              <div class="row">
                <div class="col-lg-8">
                  <div class="intro-body">
                    <p class="intro-title-top">
                      <br>
                    </p>
                    <h1 class="intro-title mb-4 ">
                      <span class="color-b">22 </span> רמת גן
                      <br> מגדלי הבורסה
                    </h1>
                    <p class="intro-subtitle intro-price">
                      <span class="price-a">השכרה | 8,500</span>
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="swiper-slide carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-2.jpg)">
        <div class="overlay overlay-a"></div>
        <div class="intro-content display-table">
          <div class="table-cell">
            <div class="container">
              <div class="row">
                <div class="col-lg-8">
                  <div class="intro-body">
                    <p class="intro-title-top">
                      <br> 
                    </p>
                    <h1 class="intro-title mb-4">
                      <span class="color-b">14 </span> אשדוד
                      <br> מרינה בר
                    </h1>
                    <p class="intro-subtitle intro-price">
                     <span class="price-a">למכירה |  2,000,000</span>
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="swiper-slide carousel-item-a intro-item bg-image" style="background-image: url(assets/img/slide-3.jpg)">
        <div class="overlay overlay-a"></div>
        <div class="intro-content display-table">
          <div class="table-cell">
            <div class="container">
              <div class="row">
                <div class="col-lg-8">
                  <div class="intro-body">
                    <p class="intro-title-top">
                      <br> 
                    </p>
                    <h1 class="intro-title mb-4">
                      <span class="color-b">10</span> מגדלי יו
                      <br> תל אביב
                    </h1>
                    <p class="intro-subtitle intro-price">
                      <a ><span class="price-a">להשכרה |  7,500</span></a>
                    </p>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="swiper-pagination"></div>
  </div><!-- End Intro Section -->
</asp:Content>
