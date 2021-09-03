<template>
  <div class="navbar">
    <div class="navbar-container">
      <!-- nav logo -->
      <div class="navbar-logo">
        <a href="#" class="menu-logo">
          <div class="home-logo"></div>
        </a>
        <div class="logo">
          <a href="#">
            <img
              src="../../assets/img/Logo_Module_TiengViet_White.66947422.svg"
              alt="logo"
            />
          </a>
        </div>
      </div>
      <!-- end nav logo -->
      <!-- nav list -->
      <div class="nav-list-container">
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-dasboard"></div>
            </div>
            <span>Tổng quan</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-cash"></div>
            </div>
            <span>Tiền mặt</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-bank"></div>
            </div>
            <span>Tiền gửi</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-pu"></div>
            </div>
            <span>Mua hàng</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-sale"></div>
            </div>
            <span>Bán hàng</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-invoice"></div>
            </div>
            <span>Quản lý hóa đơn</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-stock"></div>
            </div>
            <span>Kho</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-tools"></div>
            </div>
            <span>Công cụ dụng cụ</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-assets"></div>
            </div>
            <span>Tài sản cố định</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-tax"></div>
            </div>
            <span>Thuế</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-price"></div>
            </div>
            <span>Giá thành</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-general"></div>
            </div>
            <span>Tổng hợp</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-budget"></div>
            </div>
            <span>Ngân sách</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-report"></div>
            </div>
            <span>Báo cáo</span></a
          >
        </div>
        <div class="nav-item">
          <a href="#" class="nav-item-link"
            ><div class="nav-logo-container">
              <div class="nav-logo logo-finance"></div>
            </div>
            <span>Phân tích tài chính</span></a
          >
        </div>
      </div>
      <!-- end nav list -->
    </div>
  </div>
</template>

<script>
// import ada from "../../assets/img"
export default {};
</script>

<style scoped>
.navbar {
  background: #393a3d;
  width: 178px;
  position: fixed;
  left: 0;
  top: 0;
  bottom: 0;
}

.navbar-logo {
  display: flex;
  justify-content: center;
  height: 48px;

  align-items: center;
}
.logo {
  height: 32px;
  width: 96px;
}
.logo img {
  width: 100%;
  height: 100%;
}
.menu-logo {
  width: 24px;
  height: 24px;
  margin-right: 10px;
}
.nav-list-container {
  padding-top: 14px;
  max-height: calc(100vh - 48px);
  overflow-y: auto;
}
.nav-item {
  height: 42px;
  display: flex;
  align-items: center;
}
.nav-item-link {
  text-decoration: none;
  color: #fff;
  height: 42px;
  display: flex;
  align-items: center;
  width: 100%;
  padding: 0 14px;
}
.nav-item-link:hover {
  background: #616164;
}
/* nav logo */
.nav-logo-container {
  width: 24px;
  background-size: contain;
  margin-right: 8px;
}
::-webkit-scrollbar {
  width: 6px;
  background: #fff;
}
::-webkit-scrollbar-thumb {
  background: #d4d7dc;
}
::-webkit-scrollbar-thumb:hover {
  background: #616164;
}
/* logo */
.home-logo {
  width: 24px;
  height: 24px;
  background: url("../../assets/img/Sprites.64af8f61.svg") no-repeat -424px -86px;
  margin-right: 10px;
}
.nav-logo {
  width: 24px;
  height: 24px;
  background: url("../../assets/img/Sprites.64af8f61.svg") no-repeat;
}
.logo-dasboard {
  background-position: -30px -1628px;
}
.logo-cash {
  background-position: -73px -1628px;
}
.logo-bank {
  background-position: -117px -1628px;
}
.logo-pu {
  background-position: -161px -1628px;
}
.logo-sale {
  background-position: -204px -1628px;
}
.logo-invoice {
  background-position: -249px -1628px;
}
.logo-stock {
  background-position: -291px -1628px;
}
.logo-tools {
  background-position: -336px -1628px;
}
.logo-assets {
  background-position: -378px -1630px;
}
.logo-tax {
  background-position: -423px -1630px;
}
.logo-price {
  background-position: -467px -1628px;
}
.logo-general {
  background-position: -510px -1628px;
}
.logo-budget {
  background-position: -378px -1659px;
}
.logo-report {
  background-position: -547px -1628px;
}
.logo-finance {
  background-position: -204px -1664px;
}
</style>
