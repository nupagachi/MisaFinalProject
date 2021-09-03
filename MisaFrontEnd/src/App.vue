<template>
  <div id="app">
    <Navbar />
    <Header />
    <Content />
  </div>
</template>

<script>
import Header from "./components/layout/Header.vue";
import Navbar from "./components/layout/Navbar";
import Content from "./components/layout/Content";
export default {
  name: "App",
  components: {
    Navbar,
    Header,
    Content,
  },
};
</script>

<style>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: notosans-regular, sans-serif;
  font-size: 13px;
  font-weight: 400;
}
@font-face {
  font-family: "notosans-regular";
  src: url("./assets/fonts/notosans-regular.2cb88a13.woff2") format("opentype");
}
@font-face {
  font-family: "notosans-semibold";
  src: url("./assets/fonts/notosans-semibold.df3e6dc4.woff2") format("opentype");
}
@font-face {
  font-family: "notosans-bold";
  src: url("./assets/fonts/notosans-bold.3ede5aff.woff2") format("opentype");
}
</style>
