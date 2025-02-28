<script setup>
import TicketScanner from './components/TicketScanner.vue'
import Header from './components/Header.vue'
import Footer from './components/Footer.vue'

</script>

<template>
  <v-app>
    <header>
      <Header />
    </header>

    <main>
      <div class="main-screen">
        <RouterView />
      </div>
    </main>

    <footer>
      <Footer />
    </footer>
  </v-app>
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
.v-app-bar, .v-bottom-navigation {
  background-color: #edf1e5;
}

.main-screen {
  margin-top: 80px;
  margin-bottom: 80px;
}
</style>
