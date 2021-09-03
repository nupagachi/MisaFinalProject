<template>
  <div class="modal-container">
    <div class="layout" :class="isShowModal ? 'active' : ''"></div>
    <div class="modal-wrapper" :class="isShowModal ? 'active' : ''">
      <!-- modal header -->
      <div class="modal-header-container">
        <div class="modal-header">
          <h3 class="modal-title">Thông tin nhân viên</h3>
          <div class="modal-combobox">
            <div class="combobox-customer">
              <CheckboxField :content="'Là khách hàng'" />
            </div>
            <div class="combobox-provider">
              <CheckboxField :content="'Là nhà cung cấp'" />
            </div>
          </div>
        </div>
        <div class="modal-close">
          <div class="modal-icon help-icon"></div>
          <div @click="closeModal" class="modal-icon close-icon"></div>
        </div>
      </div>
      <!-- end modal header -->
      <!-- modal content -->
      <div class="modal-content-wrapper">
        <div class="modal-content">
          <!-- modal content left -->
          <div class="modal-content-left">
            <div class="p-12 group-input">
              <div class="input-code pr-6">
                <InputField
                  :label="'Mã'"
                  v-model="employee.code"
                  :required="true"
                  :validateEmployeeCode="validateEmployeeCode"
                />
              </div>
              <div class="input-name">
                <InputField
                  :label="'Tên'"
                  v-model="employee.name"
                  :required="true"
                  :validateEmployeeName="validateEmployeeName"
                />
              </div>
            </div>
            <div class="p-12">
              <DropdownField
                :label="'Đơn vị'"
                :down="true"
                :listOption="formatOptionDepartment"
                nameField="DeparmentField"
                :value="employee.department"
                :required="true"
                :validateDeparment="validateDeparment"
                :setSelectedValue="setSelectedValue"
              />
            </div>
            <div class="p-12">
              <InputField :label="'Chức danh'" v-model="employee.position" />
            </div>
          </div>
          <!-- end modal content left -->
          <!-- modal content right -->
          <div class="modal-content-right">
            <div class="p-12 group-input">
              <div class="input-date pr-6">
                <InputField
                  :label="'Ngày sinh'"
                  type="date"
                  v-model="employee.dateOfBirth"
                />
              </div>
              <!-- gender -->
              <div class="combobox-wrapper">
                <label>Giới tính</label>
                <div class="combobox-gender">
                  <div
                    @click="(male = true), (female = false)"
                    class="comboxbox-item"
                  >
                    <div
                      class="combobox-icon"
                      :class="male ? 'active' : ''"
                    ></div>
                    <div class="combobox-content">
                      Nam
                    </div>
                  </div>
                  <div
                    @click="(male = false), (female = true)"
                    class="comboxbox-item"
                  >
                    <div
                      class="combobox-icon"
                      :class="female ? 'active' : ''"
                    ></div>
                    <div class="combobox-content">
                      Nữ
                    </div>
                  </div>
                </div>
              </div>
              <!-- end gender -->
            </div>
            <div class="p-12 group-input">
              <div class="input-editer pr-6">
                <InputField :label="'Số CMND'" v-model="employee.cmnd" />
              </div>
              <div class="input-date-rage">
                <InputField
                  :label="'Ngày cấp'"
                  type="date"
                  v-model="employee.identityDate"
                />
              </div>
            </div>
            <div class=" pr-6">
              <InputField :label="'Nơi cấp'" v-model="employee.identityPlace" />
            </div>
          </div>
          <!-- end modal content right -->
        </div>
        <!-- modal content bottom-->
        <div class="modal-content-bottom pt-24">
          <div class="p-12">
            <InputField :label="'Địa chỉ'" v-model="employee.address" />
          </div>
          <div class="p-12 group-input">
            <div class=" pr-6">
              <InputField
                :label="'ĐT di động'"
                v-model="employee.phoneNumber"
              />
            </div>
            <div class=" pr-6">
              <InputField
                :label="'ĐT cố định'"
                v-model="employee.landlinePhone"
              />
            </div>
            <div class=" pr-6">
              <InputField :label="'Email'" v-model="employee.email" />
            </div>
          </div>
          <div class="p-12 group-input">
            <div class=" pr-6">
              <InputField
                :label="'Tài khoản ngân hàng'"
                v-model="employee.stk"
              />
            </div>
            <div class=" pr-6">
              <InputField
                :label="'Tên ngân hàng'"
                v-model="employee.bankName"
              />
            </div>
            <div class=" pr-6">
              <InputField :label="'Chi nhánh'" v-model="employee.chiNhanhNH" />
            </div>
          </div>
        </div>
      </div>
      <!-- end modal content -->
      <!-- modal footer -->
      <div class="modal-footer-container">
        <div class="modal-footer">
          <div @click="closeModal" class="btn-cancel">
            <Button :content="'Hủy'" :btnWhite="true" />
          </div>
          <div class="btn-group">
            <div class="pr-12">
              <Button :content="'Cất'" :btnWhite="true" />
            </div>
            <div @click="handleSave">
              <Button :content="'Cất và Thêm'" />
            </div>
          </div>
        </div>
      </div>
      <!-- end modal footer -->
    </div>
  </div>
</template>

<script>
import Button from "./Button.vue";
import CheckboxField from "./CheckboxField.vue";
import DropdownField from "./DropdownField.vue";
import InputField from "./InputField.vue";
import moment from "moment";
import { DEPARTMENT } from "../../constants";
export default {
  props: {
    isShowModal: Boolean,
    employeeCode: Number,
    handleSaveEmployees: Function,
    employeeEdit: Object,
  },
  mounted() {
    if (this.employeeCode) {
      this.employee.code = `Code_${this.employeeCode}`;
    } else {
      if (this.employeeEdit.code) {
        this.employee = this.employeeEdit;
      }
    }
  },
  data() {
    return {
      male: true,
      female: false,
      employee: {
        code: "",
        name: "",
        gender: 1,
        dateOfBirth: null,
        cmnd: "",
        position: "",
        department: "",
        stk: "",
        bankName: "",
        chiNhanhNH: "",
      },
      validateEmployeeCode: false,
      validateEmployeeName: false,
      validateDeparment: false,
    };
  },
  watch: {
    female() {
      if (this.male === true) this.employee.gender = 1;
      else this.employee.gender = 0;
    },
    "employee.gender"() {
      if (this.employee.gender === 1) {
        this.male = true;
        this.female = false;
      } else {
        this.male = false;
        this.female = true;
      }
    },
    "employee.code"() {
      if (this.employee.code !== null && !this.closeModalReset) {
        if (this.employee.code.length == 0) {
          this.validateEmployeeCode = true;
        } else this.validateEmployeeCode = false;
      }
    },
    "employee.name"() {
      if (!this.closeModalReset) {
        if (this.employee.name.length == 0) {
          this.validateEmployeeName = true;
        } else this.validateEmployeeName = false;
      }
    },
    "employee.department"() {
      if (this.employee.department.length == 0) {
        this.validateDeparment = true;
      } else this.validateDeparment = false;
    },
  },
  computed: {
    formatOptionDepartment() {
      const formatValue = DEPARTMENT.map((item) => {
        return {
          optionId: item.value,
          optionContent: item.optionName,
          value: item.value,
        };
      });
      return formatValue;
    },
  },
  methods: {
    handleSave() {
      if (this.validate()) {
        this.handleSaveEmployees(this.employee);

        // reset modal
        // this.resetModal();
      }
    },
    validate() {
      let isCheck = true;
      if (this.employee.code.length === 0) {
        this.validateEmployeeCode = true;
        isCheck = false;
      }
      if (this.employee.name.length === 0) {
        this.validateEmployeeName = true;
        isCheck = false;
      }
      if (this.employee.department.length === 0) {
        this.validateDeparment = true;
        isCheck = false;
      }
      if (isCheck) return true;
      return false;
    },
    setSelectedValue(value) {
      this.employee.department = value;
      this.validateDeparment = false;
    },
    resetModal() {
      this.employee = {
        code: "",
        name: "",
        gender: 1,
        dateOfBirth: null,
        cmnd: "",
        position: "",
        department: "",
        stk: "",
        bankName: "",
        chiNhanhNH: "",
      };
    },
    closeModal() {
      this.$emit("handleCloseModal");
      this.validateEmployeeCode = false;
      this.validateEmployeeName = false;
      this.validateDeparment = false;
    },
    // format date
    formatDate(date) {
      return moment(date).format("DD/MM/YYYY");
    },
  },
  components: { CheckboxField, InputField, DropdownField, Button },
};
</script>

<style scoped>
.layout {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: rgba(0, 0, 0, 0.4);
  visibility: hidden;
  opacity: 0;
  z-index: 9999;
  transition: all linear 0.15s;
}
.layout.active {
  visibility: visible;
  opacity: 1;
}
.modal-wrapper {
  position: fixed;
  overflow: auto;
  overflow-y: visible;
  height: calc(100% - 34px);
  width: 900px;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%) scale(0.8);
  background: #fff;
  z-index: 10000;
  visibility: hidden;
  opacity: 0;
  transition: all linear 0.15s;
}
.modal-wrapper.active {
  visibility: visible;
  opacity: 1;
  transform: translate(-50%, -50%) scale(1);
}
/* header modal */
.modal-header-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.modal-header {
  padding: 20px 12px 20px 32px;
  display: flex;
  align-items: center;
}
.modal-title {
  font-size: 24px;
  color: #111;
  font-weight: 700;
}
.modal-combobox {
  display: flex;
}

.modal-close {
  padding: 12px;
  display: flex;
  align-items: center;
}
.combobox-customer,
.combobox-provider {
  padding: 0 19.5px;
}
.modal-icon {
  width: 24px;
  height: 24px;
  cursor: pointer;
  background: url("../../assets/img/Sprites.64af8f61.svg") no-repeat;
}
.help-icon {
  background-position: -89px -144px;
  margin-right: 10px;
}
.close-icon {
  background-position: -144px -144px;
}
/* modal content */
.modal-content-wrapper {
  padding: 0 32px 20px 32px;
}
.modal-content {
  display: flex;
}
/* input */
.group-input {
  display: flex;
  align-items: center;
}
.input-code,
.input-date-rage {
  width: 40%;
}
.input-name,
.input-editer {
  width: 60%;
}
.pr-6 {
  padding-right: 6px;
}
.pr-12 {
  padding-right: 12px;
}
.p-12 {
  padding-bottom: 12px;
}
.pt-24 {
  padding-top: 24px;
}
.pb-24 {
  padding-bottom: 24px;
}
.modal-content-left {
  padding-right: 26px;
  width: calc(50% + 26px);
}
/* combobox */
.combobox-gender {
  display: flex;
  height: 32px;
  align-items: center;
  padding: 5px 0 6px 10px;
}
.combobox-icon {
  position: relative;
  width: 18px;
  height: 18px;
  border: 1px solid #b0b0b0;
  border-radius: 50%;
  cursor: pointer;
}
.combobox-icon.active {
  border-color: #2ca01c;
}
.combobox-icon.active::before {
  content: "";
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 10px;
  height: 10px;
  border-radius: 50%;
  background: #2ca01c;
}
.comboxbox-item {
  display: flex;
}
.comboxbox-item:first-child {
  margin-right: 20px;
}
.combobox-content {
  margin-left: 10px;
}
.combobox-wrapper label {
  display: block;
  font-size: 12px;
  font-weight: 700;
  padding-left: 10px;
  margin-bottom: 4px;
}
/* modal footer */
.modal-footer-container {
  position: absolute;
  bottom: 0;
  left: 0;
  right: 0;
  height: 77px;
  padding: 0 32px;
  display: flex;
  align-items: center;
  background: #fff;
}
.modal-footer {
  display: flex;
  height: 100%;
  width: 100%;
  align-items: center;
  justify-content: space-between;
  border-top: 1px solid #babec5;
}
.btn-group {
  display: flex;
}
</style>
