<script setup>
</script>

<template>
  <v-app-bar :elevation="0">
    <v-row>
      <v-col class="d-flex align-center start ml-2">
        <v-app-bar-nav-icon @click.stop="drawer = !drawer"></v-app-bar-nav-icon>
      </v-col>
      <v-col class="d-flex align-center center">
        <v-img max-width="65%" max-height="55px" aspect-ratio="1/1" src="../img/Festyland-logo-alt.jpg" class="mx-auto"></v-img>
      </v-col>
      <v-col class="d-flex align-center justify-end mr-2">
        <div>
          <v-btn icon="mdi-check"></v-btn>
          <v-btn icon="mdi-sync"></v-btn>
        </div>
      </v-col>
    </v-row>
  </v-app-bar>

  <v-navigation-drawer
    v-model="drawer"
    :location="$vuetify.display.mobile ? 'bottom' : undefined"
    temporary
  >
    <v-list :items="items"></v-list>
  </v-navigation-drawer>
</template>


<script>
export default {
  data: () => ({
    drawer: false,
    group: null,
    items: [
      {
        title: 'Wat',
        value: 'wat',
      },
      {
        title: 'Wil',
        value: 'wil',
      },
      {
        title: 'Je',
        value: 'je',
      },
      {
        title: 'Hier?',
        value: 'hier',
      },
    ],
  }),

  watch: {
    group() {
      this.drawer = false
    },
  },
}
</script>

<style scoped>
.v-app-bar {
  background-color: #edf1e5;
}
</style>
