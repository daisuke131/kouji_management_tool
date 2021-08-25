drop table kouji_kanri;
create table kouji_kanri (
        no                            varchar(12)               not null,
        kouji_no                      varchar(255),
        kouji_nm                      varchar(255),
        kouosyu_code                  varchar(1),
        kouji_kingaku                 numeric,
        shitauke_flg                  varchar(1),
        bikou                         varchar(255),
        del_flg                       smallint,
        cre_time                      timestamp,
        cre_id                        varchar(40),
        upd_time                      timestamp,
        upd_id                        varchar(40),
constraint pk_kouji_kanri primary key (no)
);

A5:SQL Mk-2の場合最後のコロンいらない