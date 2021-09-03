<template>
  <div>
    <ConfirmModal
      :isShowConfirmModal="isShowConfirmModal"
      :employee="employeeDelete"
      @handleCloseModal="handleCloseModal"
      :deleteEmployee="deleteEmployee"
    />
    <div v-if="openModal">
      <Modal
        :isShowModal="openModal"
        @handleCloseModal="handleCloseEmployeeModal"
        :employeeEdit="employeeEdit"
        :handleSaveEmployees="handleSaveEmployees"
        :employeeCode:="null"
      />
    </div>

    <table class="table">
      <thead>
        <tr>
          <th class="table-head-checkbox"><CheckboxField /></th>
          <th class="m-150">
            Mã nhân viên
            <div class="line"></div>
          </th>
          <th class="m-250">
            Tên nhân viên
            <div class="line"></div>
          </th>
          <th class="m-120">
            Giới tính
            <div class="line"></div>
          </th>
          <th class="m-150">
            Ngày sinh
            <div class="line"></div>
          </th>
          <th class="m-250">
            Số CMND
            <div class="line"></div>
          </th>
          <th class="m-250">
            Chức danh
            <div class="line"></div>
          </th>
          <th class="m-250">
            Tên đơn vị
            <div class="line"></div>
          </th>
          <th class="m-250">
            Số tài khoản
            <div class="line"></div>
          </th>
          <th class="m-250">
            Tên ngân hàng
            <div class="line"></div>
          </th>
          <th class="m-250">
            Chi nhánh tài khoản ngân hàng
            <div class="line"></div>
          </th>
          <th class="m-120">
            Chức năng
            <div class="line"></div>
          </th>
        </tr>
      </thead>
      <tbody>
        <Employee
          v-for="(employee, index) in listEmployee"
          :key="index"
          :employee="employee"
          :handleOpenDeleteEmployee="handleOpenDeleteEmployee"
          :handleOpenEditEmployee="handleOpenEditEmployee"
        />
      </tbody>
    </table>
  </div>
</template>

<script>
import Employee from "./Employee.vue";
import CheckboxField from "../commons/CheckboxField";
import Modal from "../commons/Modal.vue";
import ConfirmModal from "../commons/ConfirmModal.vue";
import axios from "axios";
import moment from "moment";
export default {
  props: ["listEmployee"],
  data() {
    return {
      openModal: false,
      listEmployeeByPagination: [],
      employeeDelete: {},
      employeeEdit: {},
      isShowConfirmModal: false,
    };
  },
  components: {
    Employee,
    CheckboxField,
    Modal,
    ConfirmModal,
  },
  methods: {
    // getListEmployee() {
    //   var headers = {
    //     "Access-Control-Allow-Origin": "*",
    //   };
    //   axios
    //     .get("http://localhost:5000/api/Employee", { headers })
    //     .then((resp) => {
    //       this.listEmployee = resp.data;
    //       console.log(resp.data);
    //     });
    // },
    handleOpenDeleteEmployee(employee) {
      console.log("vao day", employee);
      this.isShowConfirmModal = true;
      this.employeeDelete = employee;
    },
    handleCloseModal() {
      this.employeeDelete = {};
      this.isShowConfirmModal = false;
    },
    handleOpenEmployeeModal() {
      this.openModal = true;
    },
    handleCloseEmployeeModal() {
      this.openModal = false;
      this.employeeEdit = {};
    },
    handleOpenEditEmployee(employee) {
      this.employeeEdit = employee;
      this.handleOpenEmployeeModal();
    },
    handleSaveEmployees(employee) {
      employee.gender = employee.gender === 1 ? "Nam" : "Nữ";
      employee.dateOfBirth = moment(employee.dateOfBirth || new Date()).format(
        "YYYY-MM-DDTHH:mm:ss.SSS[Z]"
      );
      delete employee.address;
      delete employee.identityPlace;
      employee.cmnd = parseInt(employee.cmnd || 0);
      axios.put("http://localhost:5000/api/Employee", employee).then((res) => {
        console.log("res", res);
        this.handleCloseEmployeeModal();
        this.$emit("handleRefresh");
      });
    },
    deleteEmployee(id) {
      axios.delete(`http://localhost:5000/api/Employee?id=${id}`);
      this.$emit("handleRefresh");
      this.isShowConfirmModal = false;
    },
  },
  mounted() {
    // this.getListEmployee();
  },
};
</script>

<style scoped>
.table {
  border-collapse: collapse;
  width: 100%;
}
.table thead tr {
  height: 34px;
}
.table thead th {
  text-align: left;
  padding: 5px 10px;
  text-transform: uppercase;
  font-size: 12px;
  font-family: "notosans-bold";
  position: sticky;
  background: #eceef1;
  top: 0;

  border-bottom: 1px solid #c7c7c7;
  box-shadow: 0 1px 1px -1px #bbb;
  z-index: 999;
}

.m-250 {
  min-width: 250px;
}
.m-150 {
  min-width: 150px;
}
.m-180 {
  min-width: 180px;
}
.m-120 {
  min-width: 120px;
}
.th-sticky {
  right: 0;
  text-align: center !important;
}
.line {
  position: absolute;
  left: 0;
  top: 0;
  width: 1px;
  background-color: #c7c7c7;
  height: 100%;
}
</style>
