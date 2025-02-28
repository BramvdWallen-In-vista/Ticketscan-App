<script setup>
</script>

<template>
  <v-bottom-navigation :elevation="0" grow>
    <v-btn to="/" variant="text">
      <v-icon>mdi-line-scan</v-icon>
      <span>Scan code</span>
    </v-btn>
    <v-btn to="/history" variant="text">
      <v-icon>mdi-history</v-icon>
      <span>History</span>
    </v-btn>
    <v-btn to="/settings" variant="text">
      <v-icon>mdi-cog</v-icon>
      <span>Settings</span>
    </v-btn>
    <v-btn to="/logout" variant="text">
      <v-icon>mdi-logout</v-icon>
      <span>Log Out</span>
    </v-btn>
  </v-bottom-navigation>
</template>


<script>
</script>

<style scoped>
.v-bottom-navigation {
  background-color: #edf1e5;
}
</style>
