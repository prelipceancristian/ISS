<template>
  <div class="pt-5">
    <div v-for="item in items" :key="item.command">
      <ShopTile :item="item"> </ShopTile>
    </div>
  </div>
</template>

<script>
import ShopTile from './ShopTile.vue'

export default {
  name: 'HelloWorld',
  components: {
    ShopTile
  },

  data: () => ({
    items: [
      {
        title: 'Book title 1',
        description:
          'this is the book description. should be a few lines long.Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur',
        command: 'ISS-5012-833'
      },
      {
        title: 'Book title 2',
        description: 'this is the book description. should be a few lines long',
        command: 'ISS-5013-001'
      },
      {
        title: 'Book title 3',
        description: 'this is the book description. should be a few lines long',
        command: 'ISS-5014-001'
      }
    ]
  })
}
</script>
