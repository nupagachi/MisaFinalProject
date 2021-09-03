<template>
  <div class="header-container">
    <!-- header left -->
    <div class="header-left">
      <div class="header-toogle">
        <div class="header-logo toogle-logo"></div>
      </div>
      <div class="header-select">
        <div class="header-select-text">
          Công ty tnhh sản xuất-thương mại-dịch vụ qui phúc
        </div>
        <div class="header-logo logo-dropdown logo-dropdown-l"></div>
      </div>
    </div>
    <!-- end header left -->
    <!-- header-right -->
    <div class="header-right">
      <div class="header-logo logo-bell"></div>
      <div class="heaser-user">
        <div class="avatar-icon">
          <img src="../../assets/img/default-avatar.jpg" alt="avatar" />
        </div>
        <span class="name-user">Misa Final Project</span>
        <div class="header-logo logo-dropdown logo-dropdown-m"></div>
      </div>
    </div>

    <!-- end header right -->
  </div>
</template>

<script>
export default {};
</script>

<style scoped>
.header-container {
  position: absolute;
  left: 178px;
  top: 0;
  right: 0;
  background: #fff;
  display: flex;
  justify-content: space-between;
  align-items: center;
  height: 48px;
}
.header-left {
  display: flex;
  align-items: center;
}
/* tooglr */
.header-toogle {
  margin: 0 10px;
}
.toggle-btn {
  margin: 0 10px;
  width: 24px;
  height: 24px;
}
.header-select {
  display: flex;
  align-items: center;
}
.header-select-text {
  text-transform: uppercase;
  font-size: 14px;
  color: #111;
  font-family: "notosans-bold";
}

.header-logo {
  width: 24px;
  height: 24px;
  background: url("../../assets/img/Sprites.64af8f61.svg") no-repeat;
  cursor: pointer;
}
.header-select {
  cursor: pointer;
}
.toogle-logo {
  background-position: -843px -30px;
}
.logo-bell {
  background-position: -787px -30px;
}
.logo-dropdown {
  margin-left: 8px;
}
.logo-dropdown-l {
  background-position: -75px -356px;
  transform: rotate(90deg);
}
/* header right */
.header-right {
  display: flex;
  align-items: center;
  padding: 0 20px;
}
.header-right .logo-dropdown-m {
  background-position: -1076px -28px;
}
.heaser-user {
  display: flex;
  padding: 0 16px;
  cursor: pointer;
  align-items: center;
}
.name-user {
  color: #111;
  font-weight: 600;
}
.avatar-icon {
  width: 32px;
  height: 32px;
  border-radius: 50%;
  background: #e8e8e9;
  overflow: hidden;
  margin: 0 8px;
}
.avatar-icon img {
  width: 100%;
}
</style>
