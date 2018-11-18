<template>
  <v-app>
    <v-toolbar app :clipped-left="clipped">
      <v-icon color="blue darken-4">chat_bubble_outline</v-icon>
      <v-toolbar-title v-text="title"></v-toolbar-title>
      <v-spacer></v-spacer>
    </v-toolbar>
    <v-content>
      <router-view />
    </v-content>
    <v-footer color="blue-grey lighten-4" :fixed="fixed" app>
      <span>Cristiano Raffi Cunha&copy; 2018</span>
    </v-footer>
  </v-app>
</template>

<script>
export default {
  data() {
    return {
      clipped: false,
      drawer: true,
      fixed: false,
      items: [
        {
          icon: "bubble_chart",
          title: "Inspire"
        }
      ],
      miniVariant: false,
      right: true,
      rightDrawer: false,
      title: "Chat"
    };
  },
  name: "App"
};
</script>
