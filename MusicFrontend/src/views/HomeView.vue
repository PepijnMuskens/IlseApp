<script>
export default{
  methods:{
      async playSound (url) {
        const axios = require('axios');
        const res = await fetch(url)
        const data = await res.json()
        var sound;
        if (data.audioData != 0) {
          sound = audioData
        }else{
          console.log(data)
        }
        if(sound) {
          
          var audio = new Audio('data:audio/mp3;base64,'+sound);
          audio.play();
        }
      }
    },
    data() { 
        return { 
          url: "https://localhost:7002/audiofiles"
        }
      }
  }

</script>

<template>
  <main>
    <input class="btn" type="text" v-model="this.url" />
    <p>url: {{ this.url }}</p>
    <button class="btn btn-primary btn-sm" @click="playSound(this.url)"><span class="fa fa-play-circle-o"></span>play sound</button>
  </main>
</template>

<style scoped>
  .btn{
    display: flex;
    width: 100%;
  }
</style>
