<template>
  <div>
    <v-avatar size="40" :style="avatarStyle">
      <img src="../assets/avatar.jpeg" :alt="user.name" />
    </v-avatar>
    <span :style="nameStyle" class="pl-1">
      {{ user.name }}
    </span>
  </div>
</template>

<script>
import constants from '../common/constants'
export default {
  name: 'User',
  props: ['user'],
  data: () => ({
    constants: constants,
    nameStyle: {
      color: constants.whitesmoke
    },
    avatarStyle: {
      border: 'solid white 2px'
    }
  })
}
</script>
