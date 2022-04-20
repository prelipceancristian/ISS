<template>
  <div>
    <div class="title">Menu</div>
    <v-list>
      <v-list-group
        v-for="categoryKey of Object.keys(routes)"
        :key="categoryKey"
        :ripple="{ class: 'white--text' }"
      >
        <template v-slot:activator>
          <v-list-item-title> {{ categoryKey }} </v-list-item-title>
        </template>
        <v-list-item
          v-for="itemKey of Object.keys(routes[categoryKey])"
          :key="itemKey"
          :ripple="{ class: 'white--text' }"
        >
          <v-list-item-icon>
            <v-icon
              v-text="
                !!routes[categoryKey][itemKey].icon
                  ? routes[categoryKey][itemKey].icon
                  : 'mdi-lightbulb-on-outline'
              "
            ></v-icon>
          </v-list-item-icon>
          <v-list-item-content>
            <v-list-item-title> {{ itemKey }} </v-list-item-title>
            <v-list-item-subtitle
              class="subtitle"
              v-if="!!routes[categoryKey][itemKey].subtext"
            >
              {{ routes[categoryKey][itemKey].subtext }}
            </v-list-item-subtitle>
          </v-list-item-content>
        </v-list-item>
      </v-list-group>
    </v-list>
  </div>
</template>

<script>
import { routes } from '../common/routes'
import constants from '../common/constants'
export default {
  name: 'NavigationDrawerContent',
  data: () => ({
    routes: routes,
    constants: constants,
    selected: {
      color: 'red'
    }
  })
}
</script>

<style scoped>
.title {
  width: 100%;
  text-align: center;
  color: white;
  padding: 30px;
  font-size: 50px !important;
}
.subtitle {
  font-size: 10px;
  padding-bottom: 10px;
}
.selected {
  color: green;
}
</style>
