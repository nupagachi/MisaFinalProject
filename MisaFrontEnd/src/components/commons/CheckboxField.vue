<template>
  <div @click="handleCheck" class="checkbox-container">
    <div class="checkbox-field">
      <div v-if="isCheck" class="check-icon"></div>
    </div>
    <div v-if="content" class="content">{{ content }}</div>
  </div>
</template>

<script>
export default {
  props: ["content"],
  data() {
    return {
      isCheck: false,
    };
  },
  methods: {
    handleCheck() {
      this.isCheck = !this.isCheck;
    },
  },
};
</script>

<style scoped>
.checkbox-container {
  display: flex;
  cursor: pointer;
}
.checkbox-field {
  width: 18px;
  height: 18px;
  border-radius: 2px;
  border: 1px solid #afafaf;
  background: #fff;
}
.check-icon {
  width: 24px;
  height: 24px;
  background: url("../../assets/img/Sprites.64af8f61.svg") no-repeat -1224px -360px;
}
.content {
  margin-left: 10px;
}
</style>
