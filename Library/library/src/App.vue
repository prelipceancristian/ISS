<template>
  <v-app style="background-color: rgba(46,64,87);">
    <v-app-bar app dark :color="constants.mainBlue">
      <v-btn icon @click="isNavigationOpen = !isNavigationOpen">
        <v-icon>mdi-menu</v-icon>
      </v-btn>
      <h1>Library-online</h1>
      <v-spacer></v-spacer>
      <User :user="testUser" v-if="isUserLoggedIn"></User>
    </v-app-bar>
    <v-navigation-drawer
      app
      v-model="isNavigationOpen"
      width="300"
      dark
      temporary
      :color="constants.black"
    >
      <NavigationDrawerContent />
    </v-navigation-drawer>
    <v-main>
      <Tiles v-if="isUserLoggedIn" />
      <LoginScreen v-else />
    </v-main>
  </v-app>
</template>

<script>
import Tiles from './components/Tiles'
import LoginScreen from './components/LoginScreen'
import constants from './common/constants'
import User from './components/User'
import NavigationDrawerContent from './components/NavigationDrawerContent'

export default {
  name: 'App',

  components: {
    Tiles,
    User,
    NavigationDrawerContent,
    LoginScreen
  },

  data: () => ({
    isNavigationOpen: false,
    constants: constants,
    testUser: {
      imageURL: '',
      name: 'Prelipcean Cristian'
    },
    isUserLoggedIn: false
  })
}
</script>
