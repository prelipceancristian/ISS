<template>
  <v-container>
    <v-row class="ma-5">
      <v-col sm="6" offset="3" class="bg-light-grey">
        <div class="form__header">
          <h2>Login</h2>
        </div>
        <br />
        <v-form ref="form" v-model="isFormValid" lazy-validation>
          <v-container>
            <v-text-field
              v-model="user"
              prepend-inner-icon="mdi-account"
              label="Username"
              required
              outlined
            ></v-text-field>
            <v-text-field
              v-model="password"
              :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
              prepend-inner-icon="mdi-lock"
              :type="showPassword ? 'text' : 'password'"
              label="Password"
              required
              outlined
              @click:append="showPassword = !showPassword"
            ></v-text-field>
            <v-row class="ma-1">
              <v-btn
                @click="$router.push('SignUp')"
                :color="constants.onyx"
                class="white--text"
              >
                Sign up
              </v-btn>
              <v-spacer></v-spacer>
              <v-btn
                :disabled="!isFormValid"
                :color="constants.sage"
                class="white--text"
                @click="submit"
              >
                Login
              </v-btn>
            </v-row>

            <p v-if="errorMessage.length > 0" class="error__message">
              {{ errorMessage }}
            </p>
          </v-container>
        </v-form>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import constants from '../common/constants'
import { loginUser } from '../axios/requests'

export default {
  data: () => ({
    constants: constants,
    user: '',
    password: '',
    errorMessage: '',
    showPassword: false,
    isFormValid: true
  }),
  methods: {
    submit () {
      loginUser({
        username: this.user,
        password: this.password
      }).then(response => {
        console.log(response)
      })
    },
    validate () {
      this.$refs.form.validate()
    }
  },
  name: 'LoginScreen'
}
</script>

<style scoped>
.bg-light-grey {
  border-radius: 10px;
  background-color: rgba(255, 255, 255, 0.95);
}
.form__header {
  color: white;
  background-color: #7289da;
  text-align: center;
  padding: 10px;
  margin-left: 10px;
  margin-right: 10px;
  margin-top: 25px;
  border-radius: 5px;
  font-family: 'Titillium Web', 'HelveticaNeue', 'Helvetica Neue', Helvetica,
    Arial, sans-serif;
}
.error__message {
  color: red;
  margin-left: 2px;
}
</style>
