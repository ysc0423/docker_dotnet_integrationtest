FROM library/postgres

ENV POSTGRES_USER admin
ENV POSTGRES_PASSWORD admin
ENV POSTGRES_DB jenkin_test

COPY integration_test/SQL/init.sql /docker-entrypoint-initdb.d/

CMD docker-entrypoint.sh postgres