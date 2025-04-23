CREATE EXTENSION IF NOT EXISTS "uuid-ossp"; -- uuid support

CREATE TABLE "Ingredientes" (
    "id"                bigint,
    "nome"              varchar(255) not null,
    "unidade_medida"    varchar(50)  not null,
    PRIMARY KEY ("id")
);

CREATE TABLE "Receitas" (
    "id"                bigint,
    "nome"              varchar(150) not null,
    "modo_preparo"      text
    PRIMARY KEY ("id")
);

CREATE TABLE "ReceitaIngredientes" (
    "id"                bigint,
    "receita_id"        bigint not null -- REFERENCES Receitas(id),
    "ingrediente_id"    bigint not null -- REFERENCES Ingredientes(id),
    "quantidade"        int
    PRIMARY KEY ("id", "receita_id", "ingrediente_id")
)

ALTER TABLE "ReceitaIngredientes" ADD FOREIGN KEY ("receita_id")        REFERENCES "Receitas" ("id")        ON DELETE CASCADE;

ALTER TABLE "ReceitaIngredientes" ADD FOREIGN KEY ("ingrediente_id")    REFERENCES "Ingredientes" ("id")    ON DELETE CASCADE;