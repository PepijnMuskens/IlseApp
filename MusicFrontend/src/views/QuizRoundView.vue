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
    }
  }

</script>

<template>
  <main class="main-div">
    <input v-model="this.guess">
      <button class="btn"  @click="getAnswers(this.guess)">Guess</button>
      <div v-for="guess in this.PossibleGuesses" :key="guess.name">
        <p>{{ guess.name + '\n~\n' + guess.artist}}</p>
      </div>
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
    width: 100%;
    padding-left: 10%;
    padding-right: 10%;
    padding-top: 20pt;
  }
</style>
