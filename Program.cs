Episodio ep1 = new Episodio(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");


Episodio ep2 = new Episodio(2, "Técnicas de aprendizado", 67);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Marcus");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
