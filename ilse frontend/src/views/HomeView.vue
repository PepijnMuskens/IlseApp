<script setup lang="ts">
class HomeView{
    methods:{
      playSound (sound: string | undefined) {
        console.log(sound)
        if(sound) {
          var audio = new Audio(sound);
          audio.play();
        }
      }
    },
    data() { 
        return { 
          url: "https://commondatastorage.googleapis.com/codeskulptor-assets/week7-bounce.m4a"
        }
      }
  }

</script>

<template>
  <main>
    <input type="text" v-model="this.url"> </input>
    <p>url: {{ this.url }}</p>
    <button class="btn btn-primary btn-sm" @click="playSound(this.url)"><span class="fa fa-play-circle-o"></span>play sound</button>
  </main>
</template>
