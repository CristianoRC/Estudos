<template>
    <containter fuild>
        <v-layout row justify-center>
            <v-dialog v-model="dialog" persistent max-width="600">
                <v-card>
                    <v-card-title class="headline">Nome do usuário</v-card-title>
                    <v-flex sm10 offset-sm1>
                        <v-text-field v-model="nome" label="Seu nome" color="blue darken-4"></v-text-field>
                    </v-flex>
                    <v-card-actions>
                        <v-spacer></v-spacer>
                        <v-btn :disabled="!nome" @click.native="atualizarNome">Salvar</v-btn>
                    </v-card-actions>
                </v-card>
            </v-dialog>
        </v-layout>

        <v-layout mt-5 column align-center>
            <h1>Chat online <v-icon large color="blue darken-4">chat_bubble_outline</v-icon>
            </h1>
            <v-btn small flat @click.native="dialog = true">
                Atualizar nome
                <v-icon right dark>edit</v-icon>
            </v-btn>
        </v-layout>
        <div id="mensagens">
            <v-layout mt-5 row align-center>
                <v-flex md8 offset-md2>
                    <v-card>
                        <v-list two-line>
                            <template v-for="(item,index) in mensagens">
                                <v-list-tile :key="index">
                                    <v-list-tile-avatar>
                                        <v-icon large>account_circle</v-icon>
                                    </v-list-tile-avatar>
                                    <v-list-tile-content>
                                        <v-list-tile-title v-html="item.mensagem"></v-list-tile-title>
                                        <v-list-tile-sub-title v-html="item.nome"></v-list-tile-sub-title>
                                    </v-list-tile-content>
                                </v-list-tile>
                            </template>
                        </v-list>
                    </v-card>
                </v-flex>
            </v-layout>
        </div>
        <v-layout mt-5 row align-center>
            <v-flex offset-sm2 xs12 sm7>
                <v-text-field v-model="mensagem" label="Mensagem" color="blue darken-4"></v-text-field>
            </v-flex>
            <v-flex>
                <v-btn @click="criarMensagem()" color="primary" dark>
                    Enviar <v-icon dark right>send</v-icon>
                </v-btn>
            </v-flex>
        </v-layout>
    </containter>
</template>

<script>
export default {
  watch: {
    $route(r) {
      if (r.name === "Chat") this.init();
    }
  },
  created() {
    this.init();
  },
  data() {
    return {
      timer: "",
      dialog: false,
      mensagem: "",
      nome: "",
      mensagens: []
    };
  },
  methods: {
    criarMensagem() {
      var bodyPost = { nome: this.nome, mensagem: this.mensagem };

      this.$http.post("http://192.168.100.100:3000/mensagem", bodyPost).then();

      this.mensagens.push(bodyPost);
      this.mensagem = "";
    },
    atualizarMensagens() {
      this.$http.get("http://192.168.100.100:3000/mensagem").then(response => {
        this.mensagens = response.body;
      });
      this.updateScroll();
    },
    updateScroll() {
      let modalMensagens = document.getElementById("mensagens");

      if (modalMensagens.scrollHeight != null)
        modalMensagens.scrollTo(0, modalMensagens.scrollHeight);
    },
    verificarNome() {
      let nomeTemp = localStorage.getItem("nome");
      if (!nomeTemp) this.dialog = true;
      else this.nome = nomeTemp;
    },
    atualizarNome() {
      localStorage.setItem("nome", this.nome);
      this.dialog = false;
    },
    init() {
      this.verificarNome();
      this.timer = setInterval(this.atualizarMensagens, 100);
    }
  }
};
</script>

<style>
#mensagens {
  overflow: scroll;
  max-height: 38rem;
  overflow-x: hidden;
  overflow-y: hidden;
}
html {
  overflow: hidden;
}
</style>