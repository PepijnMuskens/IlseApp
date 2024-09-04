<script>
export default{
  methods:{
    async getAnswers(guess){
      if(guess != 0){
        const requestOptions = {
          method: 'GET',
          headers: { 'x-rapidapi-key': '662ba3d517mshcb3fea0ab3dc1b6p1d560ejsnb261a4d1e441' }
        }
        const res = await fetch('https://shazam.p.rapidapi.com/search?term='+ guess, requestOptions)
        const data = await res.json()
        console.log(data.tracks.hits)
        var i =0;
        data.tracks.hits.forEach(element => {
          this.PossibleGuesses[i] = {name:element.track.title, artist:element.track.subtitle}
          i++;
        });
      }
      
      },
      async tempfunction(){

      }
    },
    data(){
        return{
          guess: '',
          PossibleGuesses:[
            {
              name:'',
              artist: ''
            }
          ],
            round:{
                name:'',
                number: 0,
                score: 0,
                songs:[
                    Object
                ]
            }
        }
    },
    async beforeMount(){
      const requestOptions = {
          method: 'GET',
          params: { 'id': this.$route.params.id }
        }
      const res = await fetch('https://musiq-quiz.onrender.com/roundinfo',requestOptions)
      console.log(res)
        const data = await res.json()
       
    }
  }

</script>

<template>
  <main class="main-div">
    <div class="answers-div">
      <input v-model="this.guess">
        <div v-for="guess in this.PossibleGuesses" :key="guess.name" style="padding-top: 10pt;">
          <p>{{ guess.name + '\n~\n' + guess.artist}}</p>
        </div>
    </div>
    <button class="btn"  @click="getAnswers(this.guess)">Guess</button>
  </main>
</template>

<style scoped>
  .btn{
    width: 200pt;
    height: 80pt;
    text-align: center;
    background-color: blue;
  }

  .main-div{
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: space-between;
    width: 100%;
    height: 100%;
  }

  .answers-div{
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: start;
    width: 100%;
    height: 100%;
  }
</style>
