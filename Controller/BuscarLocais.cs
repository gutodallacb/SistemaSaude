using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using SistemaSaude.Model;

namespace SistemaSaude.Controller
{
	public class BuscarLocais
	{
		public string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/43/municipios";

		public async Task<List<_Cidade>> ObterCidadesRS()
		{
			using (HttpClient client = new HttpClient())
			{
				try
				{
					HttpResponseMessage response = await client.GetAsync(url);
					response.EnsureSuccessStatusCode();

					string jsonResponse = await response.Content.ReadAsStringAsync();
					var cidades = JsonSerializer.Deserialize<List<_Cidade>>(jsonResponse);

					return cidades;
				}
				catch (Exception ex)
				{
					throw new Exception("Erro ao obter cidades: " + ex.Message);
				}
			}
		}
	}
}