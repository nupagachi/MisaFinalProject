<template>
  <div :class="['btn', btnWhite ? 'btn-white' : '']">
    <span>{{ content }}</span>
  </div>
</template>

<script>
export default {
  props: ["content", "btnWhite"],
};
</script>

<style scoped>
.btn {
  height: 36px;
  padding: 8px 20px;
  color: #fff;
  cursor: pointer;
  background: #2ca01c;
  border-radius: 3px;
  display: inline-flex;
  justify-content: center;
  align-items: center;
}

.btn:hover {
  background: #35bf22;
}

.btn:active {
  background: #01b075;
}

.btn.btn-white {
  background: #fff;
  border: 1px solid #8d9096;
  color: #111;
}
.btn.btn-white span {
  font-weight: 600;
}
.btn.btn-white:hover {
  background-color: #d2d3d6;
}
</style>
