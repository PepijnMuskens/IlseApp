<script>
export default{
  methods:{
      async playSound (url) {
        
        const res = await fetch(url)
        const data = await res.json()
      
        if (data.fullSongBase64 != 0) {
          var sound = data.fullSongBase64
          console.log(sound)
          var audio = new Audio('data:audio/mpeg;base64,'+sound);
          audio.play();
          
        }else{
          console.log(data)
        }
      }
    },
    data() { 
        return { 
          url: "https://musiq-quiz.onrender.com/api/audiofiles/3"
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
