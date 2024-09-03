<script>
export default{

  }

</script>

<template>
  <main class="main-div">

    <div>

    </div>

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

  .main-div{
    width: 100%;
    padding-left: 10%;
    padding-right: 10%;
    padding-top: 20pt;
  }
</style>
