import React, { FC, useEffect, useState } from 'react';
import { namedapiresourcelist } from '../../Models/namedapiresourcelist';
import { Pokemon } from '../../Models/Pokemon';

interface PokemonsProps { }

const Pokemons: FC<PokemonsProps> = () => {

   const [Model, setModel] = useState<namedapiresourcelist<Pokemon>>();

   useEffect(() => {
      const fetchData = async () => {
         try {
            const response = await fetch('https://localhost:44349/Pokemon/GetListPokemons');
            console.log(response);

            const data = await response.json();

            console.log(data);
            setModel(data);
         } catch (error) {
            console.error('Error al obtener los datos:', error);
         }
      }
      fetchData();
   }, []);


   return (
      <div>
         <h1>Lista de pokemones</h1>
         <ul>
            {Model?.results.map((item, index) => (
               <li key={index}>
                  <strong>{item.name}</strong>
                  <img src={item.sprites.front_default} alt='imagen frontal'></img>
               </li>
            ))}
         </ul>
      </div>
   )
}


export default Pokemons;
