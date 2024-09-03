<script>
export default{
  methods:{
      async StartQuiz () {
        
        const res = await fetch('https://musiq-quiz.onrender.com/startquiz')
        const data = await res.json()
        if (data.id != 0) {
          this.$router.push({ name: 'QuizRound', params:{id: data.id}})
        }else{
          console.log(data)
        }
      }
    }
  }

</script>

<template>
  <main class="main-div">
      <button class="btn" @click="StartQuiz()">Start Quiz</button>
  </main>
</template>

<style scoped>
  .btn{
    width: 200pt;
    height: 80pt;
    text-align: center;
    background-color: pink;
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
